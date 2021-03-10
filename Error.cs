﻿/*******************************************************************************
  * Copyright (C) 2021 AgGateway and ADAPT Contributors
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Rob Cederberg, Kelly Nelson - initial implementation
  *******************************************************************************/


using AgGateway.ADAPT.ApplicationDataModel.ADM;

namespace AgGateway.ADAPT.ShippedItemInstancePlugin
{
    public class Error : IError
    {
        public Error(string id, string source, string description, string stacktrace)
        {
            Id = id;
            Source = source;
            Description = description;
            StackTrace = stacktrace;
        }

        public string Id { get; set; }

        public string Source { get; set; }

        public string Description { get; set; }

        public string StackTrace { get; set; }
    }
}
