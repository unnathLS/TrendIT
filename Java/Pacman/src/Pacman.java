import java.awt.*;
import java.awt.event.*;
import java.util.HashSet;
import java.util.Random;
import javax.swing.*;

public class Pacman extends JPanel {
  class Block {
    int x;
    int y;
    int width;
    int height;
    Imagem image;

    int startX;
    int startY;

    Block(Image Image, int x, int y, int width, int height) {
      this.image = image;
      this.x = x;
      this.y = y;
      this.width = width;
      this.height = height;
      this.startX = x;
      this.startY = y;

    }
  }

  // Variavel da tamanho tabuleiro do Pacman
  private int rowCount = 21;
  private int columnCount = 19;
  private int tileSize = 32;
  private int boardWidth = columnCount * tileSize;
  private int boardHeight = rowCount * tileSize;

  // Variavel das imagems
  private Image wallImgame;
  private Image blueGhostImage;
  private Image orangeGhostImage;
  private Image pinkGhostImage;
  private Image redGhostImage;

  private Image pacmanRightImage;
  private Image pacmanLeftImage;
  private Image pacmanUpImage;
  private Image pacmanDownImage;

  HashSet<Block> walls;
  HashSet<Block> foods;
  HashSet<Block> ghosts;
  Block pacman;

  // Constructor
  Pacman() {
    setPreferredSize(new Dimension(boardWidth, boardHeight));
    setBackground(Color.BLACK);

    // Carregando Imagem
    wallImgame = new ImageIcon(getClass().getResource("./wall.png")).getImage();
    blueGhostImage = new ImageIcon(getClass().getResource("./blueGhost.png")).getImage();
    orangeGhostImage = new ImageIcon(getClass().getResource("./orangeGhost.png")).getImage();
    pinkGhostImage = new ImageIcon(getClass().getResource("./pinkGhost.png")).getImage();
    redGhostImage = new ImageIcon(getClass().getResource("./redGhost.png")).getImage();

    pacmanRightImage = new ImageIcon(getClass().getResource("./pacmanRight.png")).getImage();
    pacmanLeftImage = new ImageIcon(getClass().getResource("./pacmanLeft.png")).getImage();
    pacmanUpImage = new ImageIcon(getClass().getResource("./pacmanUp.png")).getImage();
    pacmanDownImage = new ImageIcon(getClass().getResource("./pacmanDown.png")).getImage();

  }

  private String[] tileMap = {
      "XXXXXXXXXXXXXXXXXXX",
      "X        X        X",
      "X XX XXX X XXX XX X",
      "X                 X",
      "X XX X XXXXX X XX X",
      "X    X       X    X",
      "XXXX XXXX XXXX XXXX",
      "OOOX X       X XOOO",
      "XXXX X XXrXX X XXXX",
      "O       bpo       O",
      "XXXX X XXXXX X XXXX",
      "OOOX X       X XOOO",
      "XXXX X XXXXX X XXXX",
      "X        X        X",
      "X XX XXX X XXX XX X",
      "X  X     P     X  X",
      "XX X X XXXXX X X XX",
      "X    X   X   X    X",
      "X XXXXXX X XXXXXX X",
      "X                 X",
      "XXXXXXXXXXXXXXXXXXX"
  };

}
