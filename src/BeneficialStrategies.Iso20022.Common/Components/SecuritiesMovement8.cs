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
[IsoId("_qJOe4StEEeySlt9bF77XfA")]
[DisplayName("Securities Movement")]
public partial record SecuritiesMovement8
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument are to be delivered or received 
    /// </summary>
    [IsoId("_qhOIIStEEeySlt9bF77XfA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_qhOIIytEEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_qhOIJStEEeySlt9bF77XfA")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public required Quantity51Choice_ SecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Securities movement status.
    /// </summary>
    [IsoId("_qhOIJytEEeySlt9bF77XfA")]
    [DisplayName("Movement Status")]
    [IsoXmlTag("MvmntSts")]
    public SecuritiesMovementStatus1Choice_? MovementStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral.
    /// </summary>
    [IsoId("_qhOIKStEEeySlt9bF77XfA")]
    [DisplayName("Collateral Movement")]
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CollateralMovement { get; init; } 
    
    /// <summary>
    /// Indicates whether the proposed securities movements can be accepted.
    /// </summary>
    [IsoId("_qhOIKytEEeySlt9bF77XfA")]
    [DisplayName("Securities Movements Approved")]
    [IsoXmlTag("SctiesMvmntsApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecuritiesMovementsApproved { get; init; } 
    
    /// <summary>
    /// Indicates whether the position is fixed (post settlement).
    /// </summary>
    [IsoId("_qhOILStEEeySlt9bF77XfA")]
    [DisplayName("Position Type")]
    [IsoXmlTag("PosTp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PositionType { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_qhOILytEEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_aAHGQytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Reference assigned by the party A to the financial instrument movement.
    /// </summary>
    [IsoId("_qhOIMStEEeySlt9bF77XfA")]
    [DisplayName("Client Securities Movement Identification")]
    [IsoXmlTag("ClntSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientSecuritiesMovementIdentification { get; init; } 
    
    /// <summary>
    /// Reference assigned by the triparty-agent/service-provider to the financial instrument movement.
    /// </summary>
    [IsoId("_qhOIMytEEeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Securities Movement Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; init; } 
    
    /// <summary>
    /// Value of the collateral position.
    /// </summary>
    [IsoId("_qhOINStEEeySlt9bF77XfA")]
    [DisplayName("Margined Value")]
    [IsoXmlTag("MrgndVal")]
    public AmountAndDirection44? MarginedValue { get; init; } 
    
    
    #nullable disable
    
}
