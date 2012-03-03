using System.Collections.Generic;

namespace SamuraiWars.Model
{
public class Castle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public byte[] Banner { get; set; }

    public List<Samurai> Samurais { get; set; }
}
}

