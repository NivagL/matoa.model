﻿using System.Collections.ObjectModel;
namespace Matoa.Model;

public class Role
{
  public int Id { get; set; } = 0;
  public string Name { get; set; } = string.Empty;
  public Collection<UserRole> UserRoles { get; set; } = [];
}
