// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a withdrawal from an ATM.
/// </summary>
[IsoId("_U0PCoIn1EeS9F4Qrq_eaVA")]
[DisplayName("ATM Withdrawal Request")]
public partial record ATMWithdrawalRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_oJHMoIn1EeS9F4Qrq_eaVA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment1 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_1pdaIIofEeSirOZJBRz_nA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext1 Context { get; init; } 
    
    /// <summary>
    /// Withdrawal transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_Ll608IohEeSirOZJBRz_nA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction1 Transaction { get; init; } 
    
    
    #nullable disable
    
}
