Feature: Facebook Login

@launch
Scenario: Successful Login to Facebook
    Given I navigate to the Facebook login page
    Then I close the saved credentials pop up
    Then I click on email field
    And I enter my mailid
    Then I click on password field
    And I entered my password
    And i ckick on login button
    Then I should be logged in successfully