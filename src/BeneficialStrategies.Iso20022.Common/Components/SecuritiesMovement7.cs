// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Movements of securities.
/// </summary>
[IsoId("_9t61QSs-EeySlt9bF77XfA")]
[DisplayName("Securities Movement")]
public partial record SecuritiesMovement7
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is to be delivered or received.
    /// </summary>
    [IsoId("_-FwtgSs-EeySlt9bF77XfA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required CollateralEntryType1Code SecuritiesMovementType { get; init; } 
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_-Fwtgys-EeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_-FwthSs-EeySlt9bF77XfA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral or as a loan.
    /// </summary>
    [IsoId("_-Fwthys-EeySlt9bF77XfA")]
    [DisplayName("Collateral Movement")]
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CollateralMovement { get; init; } 
    
    /// <summary>
    /// Reference assigned by the party A to the financial instrument movement.
    /// </summary>
    [IsoId("_-FwtiSs-EeySlt9bF77XfA")]
    [DisplayName("Client Securities Movement Identification")]
    [IsoXmlTag("ClntSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientSecuritiesMovementIdentification { get; init; } 
    
    /// <summary>
    /// Reference assigned by the triparty agent to the financial instrument movement.
    /// </summary>
    [IsoId("_-Fwtiys-EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Securities Movement Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; init; } 
    
    
    #nullable disable
    
}
