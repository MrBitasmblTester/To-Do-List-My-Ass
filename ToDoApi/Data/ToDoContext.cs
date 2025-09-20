// ToDoApi/Data/ToDoContext.cs
public class ToDoContext : DbContext { public ToDoContext(DbContextOptions opts): base(opts) {} public DbSet<ToDoItem> ToDos { get; set; } }