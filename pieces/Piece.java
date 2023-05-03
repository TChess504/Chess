package pieces;

public abstract class Piece {

	private int xPosition;
	private int yPosition;
	private String color;
	
	
	public Piece(int xPosition, int yPosition, String color) {
		super();
		this.xPosition = xPosition;
		this.yPosition = yPosition;
		this.color = color;
	}


	public abstract void PlacesToMove();
}
