// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_UU5http-Ed-ak6NoX_4Aeg_-1582954792")]
    [DisplayName("Repo Call Request Status")]
    public record RepoCallRequestStatus : Status1Choice_ { }
}
