﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace Ivony.Html.Web
{
  public interface IPartialMapper
  {

    PartialRequestMapping MapPartial( RequestContext context );

  }
}