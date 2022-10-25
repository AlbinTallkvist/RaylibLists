using Raylib_cs; 

Raylib.InitWindow(800, 600, "Listdemo");
Raylib.SetTargetFPS(60);

List<Rectangle> walls = new List<Rectangle>();

walls.Add(new Rectangle(20,20,32,32)); // 0  ,[0]
walls.Add(new Rectangle(300,20,32,32)); // 1  ,[1]
walls.Add(new Rectangle(700,20,32,32)); // 2  ,[2]

Random generator = new Random();
int i = generator.Next(walls.Count);

while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    foreach (Rectangle Wall in walls)
    {
        Raylib.DrawRectangleRec(Wall, Color.RED);
    }

    Raylib.DrawRectangleRec(walls[i], Color.RED);

    Raylib.EndDrawing();
}