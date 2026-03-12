// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_UVDSstp-Ed-ak6NoX_4Aeg_688107606")]
    [DisplayName("Inferred Matching Status")]
    public partial record InferredMatchingStatus : Status1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
