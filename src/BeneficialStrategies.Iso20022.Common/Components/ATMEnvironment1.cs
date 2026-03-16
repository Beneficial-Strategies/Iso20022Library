// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
[IsoId("_hu8lkIn1EeS9F4Qrq_eaVA")]
[DisplayName("ATM Environment")]
public record ATMEnvironment1
{
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_7f40EIn1EeS9F4Qrq_eaVA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_Yw8TUIn2EeS9F4Qrq_eaVA")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_lKpa8In2EeS9F4Qrq_eaVA")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_GNQDwIn4EeShMpas3885ww")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine1 ATM { get; init; }

    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    [IsoId("_6G6hEIoYEeSirOZJBRz_nA")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer1 Customer { get; init; }

    /// <summary>
    /// Card performing the withdrawal transaction.
    /// </summary>
    [IsoId("_ePb1IIoeEeSirOZJBRz_nA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard16? Card { get; init; }
}
