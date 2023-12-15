Feature: British Airways Website Navigation

Validates different navigation in British Airways Home page

@BritishAirwaysNavigations
  Scenario: Verify navigation to the British Airways Website
    Given the user is on the Browser
    When the user navigates to URL "https://www.britishairways.com/travel/home/public/en_gb/"
    Then the user should be on the home page and title should be "British Airways | Book Flights, Holidays, City Breaks & Check In Online"


@BritishAirwaysNavigations
  Scenario: Verify navigation to the flights page
    Given the user is on the British Airways website
    When the user clicks on the "Flights" link
    Then the user should be on the flights page

