jumpE_basic.base_runner.CommandRegistry.add_command( "Aside" , SheetsPlus.ASheet.Aside );
jumpE_basic.base_runner.CommandRegistry.add_command( "Acall" , SheetsPlus.ASheet.Acall );
jumpE_basic.base_runner.CommandRegistry.add_command( ">M>" , SheetsPlus.ASheet.MethodCall );
jumpE_basic.base_runner.CommandRegistry.add_command( "M>>" , SheetsPlus.ASheet.BeginMethod);
jumpE_basic.Data.add_custtype( "ASheet",typeof(SheetsPlus.ASheet) );
