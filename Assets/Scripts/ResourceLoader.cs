// ------------------------------------------------------------------------------
//  para cargar de forma mas optimizada los recursos
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader
{
  private Dictionary<string, UnityEngine.Object> resources;
  private static ResourceLoader instance;

  private ResourceLoader()
  {
    resources = new Dictionary<string,UnityEngine.Object >();
  }
  
  public static ResourceLoader Instance { 
    get { 
      if (instance == null)
        instance = new ResourceLoader();
        
      return instance; 
    } 
  }
  
  public static T Load<T>(String resourcePath) where T : UnityEngine.Object
  {
    if (Instance.resources.ContainsKey(resourcePath))
      return Instance.resources [resourcePath] as T;
    else
      {
        UnityEngine.Object asset = Resources.Load(resourcePath);
        Instance.resources.Add(resourcePath, asset);
        return (T)asset;
      }
  }
}


