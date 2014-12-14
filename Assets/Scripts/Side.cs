﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Side {
	Up, Down, Left, Right, None, UpLeft, UpRight, DownLeft, DownRight
}

public static class SideMethods {

	public static Side[] AllSides() {
		return new Side[]{Side.Up, Side.Down, Side.Left, Side.Right, Side.UpLeft, Side.UpRight, Side.DownLeft, Side.DownRight};
	}

	public static int DeltaX(this Side s) {
		switch (s) {
			case Side.Left: return -1;
			case Side.Right: return 1;
			default:
				throw new Exception("Implement me");
		}
	}

	public static int DeltaY(this Side s) {
		switch (s) {
			case Side.Up: return -1;
			case Side.Down: return 1;
			default:
				throw new Exception("Implement me");
		}
	}

	public static Side Opposite(this Side s) {
		switch (s) {
			case Side.Up: return Side.Down;
			case Side.Down: return Side.Up;
			case Side.Left: return Side.Right;
			case Side.Right: return Side.Left;
		}
		throw new Exception("Opposite for " + s + "?");
	}

	public static float ToRotation(this Side s) {
		switch (s) {
			case Side.Left: return 90;
			case Side.Up: return 0;
			case Side.Right: return -90;
			case Side.Down: return 180;
			case Side.UpLeft: return 45;
			case Side.UpRight: return -45;
			case Side.DownLeft: return 135;
			case Side.DownRight: return -135;
		}
		throw new Exception("Rotation what? " + s);
	}
}