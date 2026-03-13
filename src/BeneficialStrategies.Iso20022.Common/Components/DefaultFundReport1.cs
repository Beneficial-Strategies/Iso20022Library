// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the calculation of the default fund and the collateral that has been posted by the clearing member.
/// </summary>
[IsoId("_-ddILaMOEeCojJW5vEuTEQ_1402285716")]
[DisplayName("Default Fund Report")]
public partial record DefaultFundReport1
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the calculation of the clearing member contribution to the default fund.
    /// </summary>
    [IsoId("_-ddILqMOEeCojJW5vEuTEQ_1576502363")]
    [DisplayName("Default Fund Calculation")]
    [IsoXmlTag("DfltFndClctn")]
    public ValueList<DefaultFund1> DefaultFundCalculation { get; init; } = [];
    // ID for the above is _-ddILqMOEeCojJW5vEuTEQ_1576502363
    
    /// <summary>
    /// Provides details about the collateral held.
    /// </summary>
    [IsoId("_-ddIL6MOEeCojJW5vEuTEQ_-1115881016")]
    [DisplayName("Collateral Description")]
    [IsoXmlTag("CollDesc")]
    public ValueList<Collateral3> CollateralDescription { get; init; } = [];
    // ID for the above is _-ddIL6MOEeCojJW5vEuTEQ_-1115881016
    
    /// <summary>
    /// Excess amount that the central counterparty will restitute to the clearing member or deficit to be provided by the member for the guarantee fund.
    /// </summary>
    [IsoId("_-dm5IKMOEeCojJW5vEuTEQ_-1642876959")]
    [DisplayName("Net Excess Or Deficit")]
    [IsoXmlTag("NetXcssOrDfcit")]
    public required AmountAndDirection21 NetExcessOrDeficit { get; init; } 
    
    
    #nullable disable
    
}
