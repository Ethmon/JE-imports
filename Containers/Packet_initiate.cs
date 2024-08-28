Base.commandRegistry.add_command("Pair",new Pair_instantiate());
Base.commandRegistry.seters.Add("Pair", Pair.Pair_set);
Base.Mathss.Add("!$0P!",Pair.get1);
Base.Mathss.Add("!$1P!",Pair.get2);
// add a Pair dic to the custtype in data
D.custom_types["Pair"] = new Dictionary<string,object>();