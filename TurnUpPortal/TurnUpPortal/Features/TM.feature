Feature: Time Management

Scenario: Create the Time record
    Given I login into TurnUp portal successfully
    When I navigate to Time and Material page
    And I create time record
    Then the record should be created successfully