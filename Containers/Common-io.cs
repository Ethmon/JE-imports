jumpE_basic.base_runner.CommandRegistry.add_command( "int" , common.Jint.sett );
jumpE_basic.base_runner.CommandRegistry.seters.Add( "int" , common.Jint.set );
jumpE_basic.Data.add_custtype( "int",typeof(common.Jint) );
jumpE_basic.base_runner.CommandRegistry.listsaaa.Add("int",common.Jint.listSet);

jumpE_basic.base_runner.CommandRegistry.add_command( "double" , common.Jdouble.sett );
jumpE_basic.base_runner.CommandRegistry.seters.Add( "double" , common.Jdouble.set );
jumpE_basic.Data.add_custtype( "double",typeof(common.Jdouble) );
jumpE_basic.base_runner.CommandRegistry.listsaaa.Add("double",common.Jdouble.listSet);

jumpE_basic.base_runner.CommandRegistry.add_command( "string" , common.Jstring.sett );
jumpE_basic.base_runner.CommandRegistry.seters.Add( "string" , common.Jstring.set );
jumpE_basic.Data.add_custtype( "string" ,typeof(common.Jstring));
jumpE_basic.base_runner.Mathss.Add("!AtString!", common.Jstring.AAT);
jumpE_basic.base_runner.Mathss.Add("!StringSize!", common.Jstring.SIZEOF);

jumpE_basic.base_runner.CommandRegistry.add_command( "StIn" , io.Standard_In.StIn );
jumpE_basic.base_runner.CommandRegistry.add_command( "Key" , io.Standard_In.Key );
jumpE_basic.base_runner.CommandRegistry.add_command( "ReadF" , io.Standard_In.readFile);
jumpE_basic.base_runner.Mathss.Add( "!Last!" , io.Standard_In.Last);
jumpE_basic.base_runner.Mathss.Add( "!KLast!" , io.Standard_In.LastK);


jumpE_basic.base_runner.CommandRegistry.add_command( "VarOut" , io.Standard_Out.VarOut);
jumpE_basic.base_runner.CommandRegistry.add_command( "StDisp" , io.Standard_Out.display);
jumpE_basic.base_runner.CommandRegistry.add_command( "WriteF" , io.Standard_Out.WriteOut);
jumpE_basic.base_runner.CommandRegistry.add_command( "SaveData", io.Standard_Out.LayerSave);