using System;

class Program {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");
    //Initializes the Grid
    int[][] InitGrid(int size){
      int[][] grid = new int[size][];
      for (int i = 0; i < grid.Length; i += 1 ){
      grid[i] = new int[]{0,0,0};
      }
      return grid;
    }
    
    //Displays the Grid
    void GridDisplay(int[][] grid){
      for (int i = 0; i < grid.Length;i += 1){
        int[] row = grid[i];
        string display = "";
        for (int j = 0; j < row.Length; j += 1){
          display = display + row[j] + " ";
        }
        Console.WriteLine(display);
      }
    }
    int[][] grid1 = InitGrid(3);
    void PlayerTurn(int[][] gamespace){
      string row = Console.ReadLine();
      string column = Console.ReadLine();
      int rowMod = int.Parse(row);
      int columnMod = int.Parse(column);
      gamespace[rowMod][columnMod] = 1;
      
    }
    //GridDisplay(grid1);
    void GameMode(){
      bool InGame = true;
      
      while(InGame){
        String a = Console.ReadLine();
        if(a == "stop"){
          InGame = false;
        }
        else if(a == "display"){
          GridDisplay(grid1);
        }
        PlayerTurn(grid1);
      }
    }
    GameMode();
  }
}
