<div id="header" align="center">
  <img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/34cfb60d-35db-4e87-91af-499ffa94b988" height="300px" alt="Pokemon Logo"/>
</div>

<div id="diagrams">
<h2 align="center">📊 D I A G R A M S 📊</h2>
<img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/32580b13-9efa-4868-a6d6-1c94301e828b" height="15px"/> 
<b>Визуализация</b> – демонстрация того, что из себя представляет наша система на основе реальных примеров.
<br>
<img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/335fb0e1-9a4a-4a16-8822-0585746eb307""/>
<hr/>

<img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/32580b13-9efa-4868-a6d6-1c94301e828b" height="15px"/>
<b>UML - диаграмма классов</b> показывает классы в системе, атрибуты и операции каждого класса, а также отношения между каждым классом.
<br>
<img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/072fc8d7-d509-4658-9860-4d050cb1d854"/>
<hr/>

<img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/32580b13-9efa-4868-a6d6-1c94301e828b" height = "15px"/>
<b>UML - диаграмма объектов</b> показывает отношения между объектами и то, как будет выглядеть система в определенный момент времени. Поскольку в объектах имеются данные, они используются для объяснения сложных отношений между объектами.
<br>
<p align="center">
  <img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/6e934184-ac8d-4dee-8b04-ba27992db6f2"/>
</p>
</div>

<div id="implementation">
<h2 align="center">👁️‍🗨️ I M P L E M E N T A T I O N 👁️‍🗨️</h2>

<table align="center">
<tr>
  <th><b>Entity</b></th>
  <th><b>Class</b></th>
</tr>
<tr>
  <td><img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/835ba365-d4fd-49c1-aabd-b0d8b10d82a2"/><br><p align="center">Slowpoke</p></td>
  <td>
  
```csharp
public class Slowpoke : Pokemon
{
    public Slowpoke()
    { 
        HP = 90;
        Attack = 65;
        Defense = 65;
        SpecialAtack = 40;
        SpecialDefense = 40;
        Speed = 15;   
    }
    
    sealed public override void Hit() => Console.WriteLine ("+Did nothing+");
    
    public void Sleep() => Console.WriteLine ("+Sleep+");
}
```
  </td>
</tr>
<tr>
  <td><img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/c40e2e09-7dc1-4ad6-82d5-f3e9d72d0a55"/><br><p align="center">Pichu</p></td>
  <td>
  
```csharp
public class Pichu : Pokemon
{
    public Pichu()
    { 
        HP = 20;
        Attack = 40;
        Defense = 15;
        SpecialAtack = 35;
        SpecialDefense = 35;
        Speed = 60;   
    }
    
    public override void Hit() => Console.WriteLine ("Use +Weak lightning+");
}
```
  </td>
</tr>
<tr>
  <td><img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/67476c28-bd8c-4de5-a5f4-8fe45ee856ab"/><br><p align="center">Pikachu</p></td>
  <td>
  
```csharp
public class Pikachu : Pichu
{
    public Pikachu()
    {
        HP += 15;    
        Attack += 15;
        Defense += 25;
        SpecialAtack += 15;
        SpecialDefense += 15;
        Speed += 30;
    }
    
    public override void Hit()
    {
        base.Hit();
        Console.WriteLine (" than use +Flash+");
    }
}
```
  </td>
</tr>
<tr>
  <td><img src="https://github.com/AlekseyShashkov/PokemonTMS/assets/17510024/90376635-8b70-428c-bba5-f33db901378a"/><br><p align="center">Raichu</p></td>
  <td>
  
```csharp
public class Raichu : Pikachu
{
    private const int SleepTime = 12;
    
    public Raichu()
    {
        HP += 25;
        Attack += 35;
        Defense += 15;
        SpecialAtack += 40;
        SpecialDefense += 30;
        Speed += 20;
    }
    
    sealed public override void Hit() => Console.WriteLine ("Use +Strong lightning+");
    
    public void SleepLong() => Console.WriteLine ($"+Sleep {SleepTime} hours+");
}
```
  </td>
</tr>
</table>
</div>
