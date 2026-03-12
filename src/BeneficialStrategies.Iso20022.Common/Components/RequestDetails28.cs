// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the financial instrument removal request.
/// </summary>
[IsoId("_3bfJsStFEeySlt9bF77XfA")]
[DisplayName("Request Details")]
public partial record RequestDetails28
{
    #nullable enable
    
    /// <summary>
    /// Specifies the  removal processing change requested.
    /// </summary>
    [IsoId("_3zn84ytFEeySlt9bF77XfA")]
    [DisplayName("Removal")]
    [IsoXmlTag("Rmvl")]
    public required RemovalTypeAndReason1 Removal { get; init; } 
    
    /// <summary>
    /// Specifies the financial instruments to be removed  (identification or attributes). 
    /// </summary>
    [IsoId("_3zn85StFEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument And Attributes")]
    [IsoXmlTag("FinInstrmAndAttrbts")]
    public RemovalProcessing2Choice_? FinancialInstrumentAndAttributes { get; init; } 
    
    /// <summary>
    /// Identifies the collateral parties of a contract.
    /// </summary>
    [IsoId("_3zn85ytFEeySlt9bF77XfA")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public CollateralParties4? Counterparty { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_3zn86StFEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_UBHi0ytFEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// References of the transaction for which the financial instrument removal request is required.
    /// </summary>
    [IsoId("_3zn86ytFEeySlt9bF77XfA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public Reference21? Reference { get; init; } 
    
    
    #nullable disable
    
}
