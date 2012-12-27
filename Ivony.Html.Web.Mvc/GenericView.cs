﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.IO;
using System.Web.Routing;
using System.Web;
using System.Web.Hosting;
using System.Web.Compilation;
using System.Web.Caching;
using Ivony.Fluent;

namespace Ivony.Html.Web.Mvc
{

  internal class GenericView : ViewBase
  {

    public GenericView( string virtualPath, bool partialMode )
    {
      Initialize( virtualPath, partialMode );
    }

    protected override void Process( IHtmlContainer container )
    {
    }
  }
}