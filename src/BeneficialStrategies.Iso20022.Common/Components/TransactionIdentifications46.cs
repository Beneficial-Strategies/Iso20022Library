// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides unambiguous instruction or transaction identification information.
/// </summary>
[IsoId("_NI7BYRIqEeyZaPkaPAzTvQ")]
[DisplayName("Transaction Identifications")]
public partial record TransactionIdentifications46
{
    #nullable enable
    
    /// <summary>
    /// Unique reference identifying the collateral management instruction from the client&apos;s point of view.  Identifies the potential match. If not available NONREF must be used.
    /// </summary>
    [IsoId("_NgKcsRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ClientCollateralInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference identifying the collateral management transaction from the client&apos;s point of view. Present in case of a decrease.
    /// </summary>
    [IsoId("_NgKcsxIqEeyZaPkaPAzTvQ")]
    [DisplayName("Client Collateral Transaction Identification")]
    [IsoXmlTag("ClntCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientCollateralTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_NgKctRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference identifying the triparty-agent/service-provider collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_NgKctxIqEeyZaPkaPAzTvQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique collateral transaction reference assigned by counterparty.
    /// </summary>
    [IsoId("_NgKcuRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Counterparty Collateral Transaction Identification")]
    [IsoXmlTag("CtrPtyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CounterpartyCollateralTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_NgKcuxIqEeyZaPkaPAzTvQ")]
    [DisplayName("Common Transaction Identification")]
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? CommonTransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}
