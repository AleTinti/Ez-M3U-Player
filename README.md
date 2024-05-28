# Ez-M3U-Player

***No existing program can effectively handle long M3U lists, so here's a simple solution (ugly af :D)***

![image](https://github.com/AleTinti/Ez-M3U-Player/assets/46496112/0bf6a22e-9a2e-4b18-9bb5-eb8649bdedd9)

Ez M3U Player is a simple and efficient tool for loading, searching, and playing M3U playlist files using VLC media player. The application provides an intuitive interface to manage your M3U files, allowing for easy navigation and playback of channels.

### Key Features
- **Load M3U Files**: Quickly load M3U playlist files into the application.
- **Search Channels**: Easily search through your loaded channels.
- **Play Channels**: Play selected channels using VLC media player.
- **User-Friendly Interface**: Simple and clean interface for easy use.

### Changelog

#### Version 1.1
- **New Feature**: Introduced an array-based data structure for handling channel data instead of temporary CSV files. This improves performance and reduces memory usage.
- **Bug Fix**: Fixed issues related to cross-thread operations in the `updateList` function.
- **Enhancement**: Improved error handling and messaging for file operations and VLC path issues.
- **UI Improvement**: Minor tweaks to UI elements for better user experience.

#### Version 1.0
- **Initial Release**: Basic functionality for loading M3U files, searching channels, and playing them using VLC.

### How to Use
1. **Load M3U File**: Click on the "Open" menu item to load your M3U file.
2. **Search Channels**: Use the search box to filter channels by name.
3. **Play Channel**: Select a channel from the list and click the "Play" button to start playback with VLC.

### Menu

 > File
 <br> - Open -> To open a M3U list

 > Settings
<br>  - List Limit -> Set the max number of elements shown in the list (usually lags over 5000! Don't load all channels)
<br>  - VLC Path -> If VLC isn't in the default folder, you can change it from here
<br>  - Help -> Useless button

### Contact
If you encounter any bugs or have suggestions for improvements, feel free to contact me:
- **Email**: aletinti12@gmail.com
- **GitHub**: [aletinti](https://github.com/aletinti)

Kiss yall