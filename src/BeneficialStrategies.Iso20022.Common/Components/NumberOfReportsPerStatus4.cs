// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number of reports per status.
/// </summary>
[IsoId("_6MfxgXA0EeuQQPLl0vKpYw")]
[DisplayName("Number Of Reports Per Status")]
public partial record NumberOfReportsPerStatus4
{
    #nullable enable
    
    /// <summary>
    /// Number of individual reports sent / received, detailed per status.
    /// </summary>
    [IsoId("_6PNuUXA0EeuQQPLl0vKpYw")]
    [DisplayName("Detailed Number Of Reports")]
    [IsoXmlTag("DtldNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfReports { get; init; } 
    
    /// <summary>
    /// Common report status for all individual reports sent / received.
    /// </summary>
    [IsoId("_6PNuU3A0EeuQQPLl0vKpYw")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required PairedReconciled3Code DetailedStatus { get; init; } 
    
    
    #nullable disable
    
}
