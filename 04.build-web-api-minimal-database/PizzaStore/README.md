# [最小 API、Entity Framework Core、および ASP\.NET Core でデータベースを使用する \- Training \| Microsoft Learn](https://learn.microsoft.com/ja-jp/training/modules/build-web-api-minimal-database/)

## SQLite データベースを設定する
### パッケージのインストール
NuGet パッケージ[Microsoft\.EntityFrameworkCore\.Sqlite 6\.0\.0](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/6.0.0)を使用する。
データベースを作成するためのデザイン時ロジックは[Microsoft\.EntityFrameworkCore\.Design 6\.0\.0](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.0)に含まれている。

```cmd
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0

dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
```

`dotnet-ef`は Entity Framework Core において、コマンドライン インターフェースによって移行の作成、移行の適応、既存のデータベースに基づくモデルの作成などを実行するためのもの。
参照: [EF Core ツールのリファレンス \(\.NET CLI\) \- EF Core \| Microsoft Learn](https://learn.microsoft.com/ja-jp/ef/core/cli/dotnet)

### EF Core に移行する
EF Core 移行ツールを使用してこのプロジェクトのモデルをデータベースへ移行する。
`ef migrations`コマンドを実行すると`Migrations`フォルダが作成され、配下にデザイン時ロジックを含むコードファイルが生成される。
`ef database update`を実行することでデータベースの移行を適応する。

```cmd
dotnet ef migrations add InitialCreate

dotnet ef database update
```
