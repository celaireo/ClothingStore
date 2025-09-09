
## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK

### Setup

1. **Clone or download the repository.**
2. **Open the solution in Visual Studio 2022.**
3. **Restore NuGet packages** (right-click solution > Restore NuGet Packages).
4. **Build the solution** (`Ctrl+Shift+B`).
5. **Set the project as Startup Project** (right-click project > Set as Startup Project).
6. **Run the application** (`F5` or `Ctrl+F5`).

### Usage

- Navigate to `/Products` to manage products.
- Use the search form to filter by name, category, or size.
- Add, edit, view, or delete products using the UI.
- Delete uses a Bootstrap modal for confirmation.
- Success messages are shown after each operation.

### Custom Tag Helpers

- `<price value="decimal">` — displays price as currency.
- `<badge text="string" variant="color">` — displays a Bootstrap badge.

### Styling

- Uses [Bootswatch Cosmo](https://bootswatch.com/cosmo/) theme via CDN in `_Layout.cshtml`.

## License

This project is for educational/demo purposes.

---

**Need help?**  
If you encounter issues, ensure you have the correct .NET SDK and that the project is set as the startup project in Visual Studio.
