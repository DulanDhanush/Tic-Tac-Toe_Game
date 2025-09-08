# 🎮 Tic Tac Toe Game (C# WinForms)

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

A classic **Tic Tac Toe (X & O)** game developed using **C# Windows Forms**. This project showcases event handling, conditional logic, UI design, and game mechanics, including a single-player mode powered by the minimax algorithm for an AI opponent. Perfect for learning C# and Windows Forms development or enjoying a quick game!

## ✨ Features
- **Two-Player Mode**: Compete as Player X against Player O.
- **Single-Player Mode**: Challenge an AI opponent (Player O) using the minimax algorithm.
- **Win Detection**: Automatically detects wins, losses, or draws.
- **Winning Line Highlight**: Highlights the winning line in green for visual feedback.
- **Score Tracking**: Keeps track of scores for both players across multiple games.
- **Game Controls**: Includes **New Game** and **Reset** buttons for easy replay.
- **User-Friendly Interface**: Simple and intuitive UI built with Windows Forms.

## 🛠️ Technologies Used
- **C#**: Core programming language for game logic and UI interaction.
- **.NET Framework**: Platform for building the Windows Forms application.
- **Visual Studio**: IDE used for development and UI design.

## 📂 Project Structure
```
Tic_Tac_Toe_Game_in_C_/
├── Form1.cs              # Main game logic and event handling
├── Form1.Designer.cs     # Auto-generated UI design code
├── Program.cs            # Application entry point
├── Tic_Tac_Toe_Game_in_C_.csproj  # Project configuration file
```

## 🚀 How to Run
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/TicTacToeCSharp.git
   ```
2. **Open in Visual Studio**:
   - Launch Visual Studio and open the `.csproj` file.
3. **Build the Project**:
   - Press `Ctrl + Shift + B` to build the solution.
4. **Run the Game**:
   - Press `F5` to start the game and enjoy playing!

### Prerequisites
- Visual Studio (2019 or later recommended) with .NET Framework support.
- Basic understanding of C# and Windows Forms (optional for running the game).

## 🎯 Game Rules
- **Starting Player**: Player X always starts.
- **Gameplay**:
  - In two-player mode, players alternate clicking empty squares to place their mark (X or O).
  - In single-player mode, Player X (human) plays against Player O (AI).
- **Winning Condition**: The first player to align three marks in a row (horizontally, vertically, or diagonally) wins.
- **Draw Condition**: If all nine squares are filled without a winner, the game ends in a draw.
- **Controls**:
  - Click a square to place your mark.
  - Use the **New Game** button to start a new round without resetting scores.
  - Use the **Reset** button to clear the board and reset scores.

## 📸 Screenshots

<img width="1207" height="693" alt="image" src="https://github.com/user-attachments/assets/21866910-0151-41bd-93fd-292ee35318e1" />

```

## 🧠 Single-Player AI
The single-player mode features an AI opponent (Player O) powered by the **minimax algorithm**, which:
- Evaluates all possible moves to ensure optimal play.
- Guarantees the AI either wins or forces a draw when possible.
- Provides a challenging experience for the human player (Player X).

## 📌 Future Improvements
- **Custom Themes**: Add options for different UI themes (e.g., dark mode, colorful grids).
- **Sound Effects**: Include audio feedback for moves, wins, and draws.
- **Difficulty Levels**: Implement adjustable AI difficulty (e.g., easy, medium, hard).
- **Game Statistics**: Track and display detailed game statistics (e.g., win/loss ratios).

## 👤 Author
**Dulan Dhanush Kandeepan**  
📧 **Contact**: dulandhanush0@gmail.com 
🔗 **GitHub**: (https://github.com/DulanDhanush)

## 🤝 Contributing
Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes and commit (`git commit -m "Add your feature"`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a pull request.

## 📜 License
This project is licensed under the MIT License. See the LICENSE file for details.

---

Happy gaming! 🎉 Feel free to star ⭐ or fork this repository if you find it useful!
