Feature: British Airways Website Functionality

Validates different functionalities or features of British Airways Home page

@BritishAirwaysFunctionalities
  Scenario: Verify search functionality
    Given the user is on the British Airways website
    When the user enters a destination and clicks on the search button
    Then the user should see relevant search results

    @BritishAirwaysFunctionalities
    Scenario: Verify user login functionality
    Given the user is on the British Airways website
    When the user clicks on the Login link and enters invalid credentials
    Then the user should be shown error message

    @BritishAirwaysFunctionalities
     Scenario: Verify flight booking process
    Given the user is on the British Airways website
    When the user selects a destination, date, and click Search Flights button
    Then the user should see available flights and pricing options

        @BritishAirwaysFunctionalities
     Scenario: Verify Hotel booking process
    Given the user is on the British Airways website
    When the user selects a destination, date, and click Find Hotels button
    Then the user should see available Hotels and pricing options







