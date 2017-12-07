﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerPrefs bridge. Please limit access to the fields of this class, as they are driven by the questionable PlayerPrefs class.
/// </summary>
public static class PlayerRecords {
	private const string illuminatedKey = "illuminated";
	private const string maxDistanceKey = "max_distance";
	private const string musicKey = "music_index";
	private const string controlsKey = "controls_index";

	/// <summary>
	/// Total number of blocks illuminated in the user's entire time playing this game.
	/// </summary>
	public static int illuminated {
		get {
			return PlayerPrefs.GetInt (illuminatedKey, 0);
		}
		set {
			PlayerPrefs.SetInt (illuminatedKey, value);
		}
	}

	/// <summary>
	/// High score for distance ran.
	/// </summary>
	public static float maxDistance {
		get {
			return PlayerPrefs.GetFloat (maxDistanceKey, 0f);
		}
		set {
			PlayerPrefs.SetFloat (maxDistanceKey, value);
		}
	}

	/// <summary>
	/// Index of the preferred song.
	/// </summary>
	public static int musicIndex {
		get {
			return PlayerPrefs.GetInt (musicKey, 0);
		}
		set {
			PlayerPrefs.SetInt (musicKey, value);
		}
	}

	/// <summary>
	/// Index of the preferred control scheme.
	/// </summary>
	public static int controlsIndex {
		get {
			return PlayerPrefs.GetInt (controlsKey, 0);
		}
		set {
			PlayerPrefs.SetInt (controlsKey, value);
		}
	}
}