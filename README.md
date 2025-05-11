# Haptic VR Operation Game

From ENSF 545 Introduction to Virtual Reality Course at the University of Calgary, this Unity-based VR adaptation of "Operation" uses integrated haptic feedback. The project compares user performance and experience in two versions: one with enhanced (vibration/weight) feedback and one minimal.

## Overview

- **Goal**: Test user performance and experience under different haptic conditions.  
- **Key Features**:  
  - Unity-based VR environment  
  - Haptic feedback via OpenHaptics scripts  
  - Two feedback modes: minimal vs. enhanced  

---

## File Structure
  - HapticScripts/: Contains the main C# scripts controlling haptic feedback, collisions, and interactions.
  - New Unity Project.exe: Run this to start the game, alongside a connected haptic device.
---

## How to Run

1. **Clone or download** this repository.  
2. **Connect your Haptic Stylust**   
3. Go to the folder for the desired version.  
4. **Double-click `New Unity Project.exe`** to launch the game.  

> **Note**: Both versions require a haptic device. Ensure your device drivers and Unity’s OpenHaptics plugin are properly installed.

---

## Gameplay

1. **Pick up the stylus (haptic device)** to interact with the virtual board.  
2. **Remove the pieces** from the “Operation” board (in this example, a snowman) without touching the edges and put them inside the tray, the timer will not stop until all pieces have landed inside the tray.  
3. **Listen for the beep** (`beep-01a.mp3`) to indicate a collision.  
4. **Compare performance** between the less feedback and enhanced feedback versions.
   <img width="609" alt="Screenshot 2025-01-07 at 12 26 52 AM" src="https://github.com/user-attachments/assets/5d675c32-7f52-4a11-bf19-1f068026e194" />

