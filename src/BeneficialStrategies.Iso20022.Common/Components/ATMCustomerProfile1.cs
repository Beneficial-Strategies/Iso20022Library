// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Profile of the customer selected by an ATM.
/// </summary>
[IsoId("_-JYQ8IoYEeSirOZJBRz_nA")]
[DisplayName("ATM Customer Profile")]
public record ATMCustomerProfile1
{
    /// <summary>
    /// Describes the main way customer information was collected to build up the customer menu and the withdrawal request.
    /// </summary>
    [IsoId("_r_fd8IoZEeSirOZJBRz_nA")]
    [DisplayName("Retrieval Mode")]
    [IsoXmlTag("RtrvlMd")]
    public required ATMCustomerProfile1Code RetrievalMode { get; init; }

    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_0mnEwIoZEeSirOZJBRz_nA")]
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProfileReference { get; init; }

    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_5_Kd0IoZEeSirOZJBRz_nA")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; }
}
