// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about external payment system.
/// </summary>
[IsoId("_YG0vwB9yEeapDZRA0Hb6ow")]
[DisplayName("External Payment System Details")]
public partial record ExternalPaymentSystemDetails1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant can send Register of Clearing Positions.
    /// </summary>
    [IsoId("_s4SMgB9yEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Positions Register Allowed Indicator")]
    [IsoXmlTag("ClrPossRegrAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ClearingPositionsRegisterAllowedIndicator { get; init; } 
    
    /// <summary>
    /// List of the clearing schemes.
    /// </summary>
    [IsoId("_80z6oB9yEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Circuits")]
    [IsoXmlTag("ClrCrcts")]
    public ValueList<ClearingCircuits1> ClearingCircuits { get; init; } = new ValueList<ClearingCircuits1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _80z6oB9yEeapDZRA0Hb6ow
    
    
    #nullable disable
    
}
