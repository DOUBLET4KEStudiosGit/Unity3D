# FPSLimiterTestScript

## Description

This Unity test script, `FPSLimiterTestScript`, is designed to test the functionality of the `FPSLimiter` component within your Unity project. The `FPSLimiter` component is responsible for controlling the target frame rate in your game.

## Table of Contents

- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Running the Tests](#running-the-tests)
- [Test Descriptions](#test-descriptions)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get started with these tests, follow the steps below:

### Prerequisites

Before running the tests, ensure that you have:

- Unity installed on your development machine.
- A Unity project that includes the `FPSLimiter` component.

### Running the Tests

1. Clone or download this repository to your local machine.

2. Open your Unity project that contains the `FPSLimiter` component.

3. In the Unity Editor, go to the "Window" menu and select "General" > "Test Runner."

4. In the Test Runner window, click on the "Play Mode" tab.

5. Click the "Run All" button to execute the tests.

6. The test results will be displayed in the Test Runner window.

## Test Descriptions

This script contains two Unity test methods:

1. `SetFrameRateTo60`: This test checks if the `FPSLimiter` sets the target frame rate to 60 frames per second.

2. `SetCustomFrameRate`: This test checks if the `FPSLimiter` can successfully set a custom frame rate (in this case, 30 frames per second).

Each test creates a new GameObject, attaches the `FPSLimiter` component to it, and then asserts that the `Application.targetFrameRate` has been set correctly.

## Contributing

Contributions to this project are welcome. If you find issues or have suggestions for improvements, please open an issue or create a pull request.

## License

This project is licensed under the MIT License.

---

Feel free to customize this `README.md` according to your project's needs and provide additional information if necessary. Good luck with your Unity testing!

