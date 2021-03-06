﻿Feature: GetCountries
  In order to count the number of countries
  As a user with access to the RestCountries API
  I want to be told the number of countries in the API response

  Scenario Outline: Number of countries
    Given I generate a restful request for countries
    When I receive a successful country response <Response>
    Then the api country response returns <Countries>

    Examples:      
      	| Response | Countries  |
      	| 200      | 250        |  
