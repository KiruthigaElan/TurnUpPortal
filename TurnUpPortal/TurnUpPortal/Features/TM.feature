
Feature: Time Management

  Scenario: Edit Time record
    Given I login to TurnUp portal
    When I edit a time record
    Then the record should be edited successfully