import javax.swing.JFrame;

public class App {
  public static void main(String[] args) {
    // Variavel da tamanho tabuleiro do Pacman
    int rowCount = 21;
    int columnCount = 19;
    int tileSize = 32;
    int boardWidth = columnCount * tileSize;
    int boardHeight = rowCount * tileSize;

    // Criando o tabuleiro do Pacman
    JFrame frame = new JFrame("Pac Man");
    frame.setVisible(true);
    frame.setSize(boardWidth, boardHeight);
    frame.setLocationRelativeTo(null);
    frame.setResizable(false);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    Pacman pacmanGame = new Pacman();
    frame.add(pacmanGame);
    frame.pack();
    frame.setVisible(true);

  }
}
