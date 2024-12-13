jumpE_basic.base_runner.CommandRegistry.add_command( "bool" , booleans.Jbool.sett );
jumpE_basic.base_runner.CommandRegistry.seters.Add( "bool" , booleans.Jbool.set );
jumpE_basic.Data.add_custtype( "bool",typeof(booleans.Jbool) );
jumpE_basic.base_runner.StatmentAdds.Add("Bcheck",booleans.Jbool.evaluateState);