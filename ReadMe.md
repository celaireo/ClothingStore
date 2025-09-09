# Clothing Store

An ASP.NET Core MVC web application for managing a clothing store’s product catalog.  
Implements CRUD operations, search/filtering, and custom Tag Helpers, all using an in-memory repository (no database required).

## Features

- **ASP.NET Core MVC (.NET 8)**
- **In-memory product repository** (no database)
- **CRUD**: Create, Read, Update, Delete products
- **Search/filter**: by Name, Category, and Size (enum)
- **Custom Tag Helpers**:
  - `<price value="decimal">` — formats as currency
  - `<badge text="string" variant="bootstrap-color">` — renders a Bootstrap badge
- **Bootstrap (Bootswatch Cosmo theme)** for responsive UI
- **Bootstrap modal** for delete confirmation
- **TempData** feedback messages (e.g., "Product added")
- **Strongly-typed Razor views** with validation

## Product Model

public class Product { 
	public int Id { get; set; } 
	public string Name { get; set; } 
	public string Category { get; set; } 
	public decimal Price { get; set; } 
	public DateTime ReleaseDate { get; set; } 
	public bool InStock { get; set; } 
	public Size Size { get; set; } 
	}
	public enum Size { 
	XS, S, M, L, XL, XXL 
	}
	


## Project Structure

ClothingStore/ 
│ 
├── Controllers/ 
│   └── ProductsController.cs 
├── Models/ 
│   └── Product.cs 
├── Data/ 
│   ├── IProductRepository.cs 
│   └── InMemoryProductRepository.cs 
├── TagHelpers/ 
│   ├── PriceTagHelper.cs 
│   └── BadgeTagHelper.cs 
├── Views/ 
│   ├── Shared/ 
│   │   └── _Layout.cshtml 
│   ├── Products/ 
│   │   ├── Index.cshtml 
│   │   ├── Create.cshtml 
│   │   ├── Edit.cshtml 
│   │   ├── Details.cshtml 
│   │   └── Delete.cshtml 
│   └── _ViewImports.cshtml 
├── wwwroot/ 
│   └── (static assets) 
├── Program.cs └── ClothingStore.csproj


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

### Styling

- Uses [Bootswatch Cosmo](https://bootswatch.com/cosmo/) theme via CDN in `_Layout.cshtml`.

## License

This project is for educational/demo purposes.


