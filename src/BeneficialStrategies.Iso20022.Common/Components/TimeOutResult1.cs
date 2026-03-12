// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the time-out consequences.
/// </summary>
[IsoId("_Utx7w9p-Ed-ak6NoX_4Aeg_263935845")]
[DisplayName("Time Out Result")]
public partial record TimeOutResult1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the transaction if no action is taken by the user.
    /// </summary>
    [IsoId("_Utx7xNp-Ed-ak6NoX_4Aeg_1691671340")]
    [DisplayName("Transaction Future Status")]
    [IsoXmlTag("TxFutrSts")]
    public required TransactionStatus2 TransactionFutureStatus { get; init; } 
    
    /// <summary>
    /// Describes the time-out reason.
    /// </summary>
    [IsoId("_Utx7xdp-Ed-ak6NoX_4Aeg_653870877")]
    [DisplayName("Time Out Event")]
    [IsoXmlTag("TmOutEvt")]
    public TimeOutEvent1? TimeOutEvent { get; init; } 
    
    
    #nullable disable
    
}
