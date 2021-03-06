﻿using UnityEngine;

namespace UniGit
{
	public interface IGitResourceManager
	{
		Texture2D GetTexture(string name, bool throwError = true);
        T LoadUniGitAsset<T>(string path) where T : Object;
    }
}
