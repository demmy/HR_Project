export default function VacanciesController($scope, VacancyService) {
   'ngInject';

/// <reference path="../../../typings/browser.d.ts" />

   var urlId = 'Vacancies';
   var vm = $scope;

   function getVacancies() {
      VacancyService.getVacancies(urlId).then(value => vm.vacancies = value);
   }

   vm.Vacancies = getVacancies;
}
