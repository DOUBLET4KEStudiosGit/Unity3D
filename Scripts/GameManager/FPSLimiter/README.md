# FPS Limiter for Unity 3D

The **FPS Limiter** script is a useful tool for Unity 3D developers, allowing you to control and limit the frame rate of your game. By attaching this script to a GameObject in your Unity project, you can easily set a specific target frame rate for your game.

## How it Works

Once attached to an object, the script uses the `Application.targetFrameRate` property to set the desired frame rate. You can specify the frame rate by modifying the `_framesPerSecond` variable in the Inspector. By default, it's set to 60 frames per second (FPS), but you can customize it to your preferred value.

## Usage

1. Attach the "FPSLimiter" script to a GameObject in your Unity scene.

2. In the Inspector, you can adjust the `_framesPerSecond` variable to your desired frame rate.

3. When you play your game, Unity will limit the frame rate to the specified value, ensuring a smoother and more consistent gaming experience.

This script can be particularly useful when you want to control the performance of your Unity application or when you need to ensure that your game runs at a specific frame rate on various devices.

Feel free to incorporate this script into your Unity projects to enhance your game's performance and user experience.
