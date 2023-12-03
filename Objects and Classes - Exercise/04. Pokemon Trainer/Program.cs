List<Trainer> trainers = new List<Trainer>();

string input = Console.ReadLine();
while (input != "Tournament")
{
    string[] tokens = input.Split();
    string trainerName = tokens[0];
    string pokemonName = tokens[1];
    string pokemonElement = tokens[2];
    int pokemonHealth = int.Parse(tokens[3]);

    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


    Trainer trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

    if (trainer == null)
    {
        trainer = new Trainer(trainerName);
        trainers.Add(trainer);
    }

    trainer.Pokemons.Add(pokemon);

    input = Console.ReadLine();
}

string command = Console.ReadLine();
while (command != "End")
{
    ProcessTournamentCommand(trainers, command);
    command = Console.ReadLine();
}

PrintTrainers(trainers);


static void ProcessTournamentCommand(List<Trainer> trainers, string element)
{
    foreach (Trainer trainer in trainers)
    {
        if (trainer.Pokemons.Any(p => p.Element == element))
        {
            trainer.Badges++;
        }
        else
        {
            foreach (Pokemon pokemon in trainer.Pokemons)
            {
                pokemon.Health -= 10;
            }

            trainer.Pokemons.RemoveAll(p => p.Health <= 0);
        }
    }
}

static void PrintTrainers(List<Trainer> trainers)
{
    foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
    {
        Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
    }
}