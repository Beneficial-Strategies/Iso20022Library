// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Movements of securities.
/// </summary>
[IsoId("_TSUjIStFEeySlt9bF77XfA")]
[DisplayName("Securities Movement")]
public record SecuritiesMovement9
{
    /// <summary>
    /// Specifies whether the quantity of financial instrument is to be delivered or received.
    /// </summary>
    [IsoId("_Tq6pUStFEeySlt9bF77XfA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required CollateralEntryType1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Tq6pUytFEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_Tq6pVStFEeySlt9bF77XfA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_Tq6pVytFEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_-zu_EytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral or as a loan.
    /// </summary>
    [IsoId("_Tq6pWStFEeySlt9bF77XfA")]
    [DisplayName("Collateral Movement")]
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CollateralMovement { get; init; }

    /// <summary>
    /// Reference assigned by the party A to the financial instrument movement.
    /// </summary>
    [IsoId("_Tq6pWytFEeySlt9bF77XfA")]
    [DisplayName("Client Securities Movement Identification")]
    [IsoXmlTag("ClntSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientSecuritiesMovementIdentification { get; init; }

    /// <summary>
    /// Reference assigned by the triparty agent to the financial instrument movement.
    /// </summary>
    [IsoId("_Tq6pXStFEeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Securities Movement Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; init; }
}
