
'use strict';

angular.module('employeeController', [])

    .controller('empCtrl', function ($scope, $http) {

        $scope.employeesData = {};
        $http.get('/Employees/IndexJson').then(function (response) {
            $scope.employeesData = response['data'];
            $scope.total = $scope.getTotal();
        }, function (error) {

        });
        $scope.getTotal = function () {
            var total = 0;
            for (var i = 0; i < $scope.employeesData.length; i++) {
                total += $scope.employeesData[i].Salary;
            }
            return total;
        }

        $scope.openModal = function (employee) {
            $scope.employee = {};

            $scope.employee.id = employee.EmployeeId;
            $scope.employee.name = employee.Name;
            $scope.employee.department = employee.Department;
            $scope.employee.salary = employee.Salary;
            var dlgElem = angular.element("#modalDlg");
            if (dlgElem) {
                dlgElem.modal("show");
            }

        }

        $scope.openTasksModal = function (employee) {
            $scope.getEmployeeTasks(employee.EmployeeId);
            $scope.name = employee.Name;
            var dlgElem = angular.element("#modalDlgTask");
            if (dlgElem) {
                dlgElem.modal("show");
            }
        }



        $scope.getEmployeeTasks = function (employeeId) {
            $http({ method: 'GET', url: '/Employees/EmployeeTasksJson', params: { employeeId: employeeId } }).
                then(function (response) {
                    $scope.employeeTasks = response['data'];
                });
        };

        $scope.updateSalary = function (employeeId) {
            var salaryValue = parseInt(angular.element("#salaryInput")[0].value);

            $http({
                method: 'GET', url: '/Employees/UpdateEmployeeSalaryJson',
                params: { employeeId: employeeId, salary: salaryValue }
            }).
                then(function (response) {
                    $scope.total = parseInt($scope.total) - parseInt($scope.employee.salary) + salaryValue;
                    $scope.salary = salaryValue;
                    $scope.employeesData.find(e => e.EmployeeId == employeeId).Salary = salaryValue;

                });
        };

    }
    );


