// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates which fields must be present in the response.
/// </summary>
[IsoId("_vjD5tv6yEeGNWvq8ppGEJQ_1856817548")]
[DisplayName("Customer Account Return Criteria")]
public partial record CustomerAccountReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkP6yEeGNWvq8ppGEJQ_1742978482")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Identification { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkf6yEeGNWvq8ppGEJQ_859745195")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Name { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkv6yEeGNWvq8ppGEJQ_-137327158")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Status { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDk_6yEeGNWvq8ppGEJQ_-1134399511")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Type { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlP6yEeGNWvq8ppGEJQ_-365489421")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Currency { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlf6yEeGNWvq8ppGEJQ_-1362561774")]
    [DisplayName("Monthly Payment Value")]
    [IsoXmlTag("MnthlyPmtVal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MonthlyPaymentValue { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlv6yEeGNWvq8ppGEJQ_1935333169")]
    [DisplayName("Monthly Received Value")]
    [IsoXmlTag("MnthlyRcvdVal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MonthlyReceivedValue { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDl_6yEeGNWvq8ppGEJQ_938260816")]
    [DisplayName("Monthly Transaction Number")]
    [IsoXmlTag("MnthlyTxNb")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MonthlyTransactionNumber { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmP6yEeGNWvq8ppGEJQ_-58811537")]
    [DisplayName("Average Balance")]
    [IsoXmlTag("AvrgBal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AverageBalance { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmf6yEeGNWvq8ppGEJQ_-1055883890")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AccountPurpose { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmv6yEeGNWvq8ppGEJQ_-2052956243")]
    [DisplayName("Floor Notification Amount")]
    [IsoXmlTag("FlrNtfctnAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FloorNotificationAmount { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDm_6yEeGNWvq8ppGEJQ_1244938700")]
    [DisplayName("Ceiling Notification Amount")]
    [IsoXmlTag("ClngNtfctnAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CeilingNotificationAmount { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDnP6yEeGNWvq8ppGEJQ_247866347")]
    [DisplayName("Statement Cycle")]
    [IsoXmlTag("StmtCycl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StatementCycle { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kP6yEeGNWvq8ppGEJQ_-749206006")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ClosingDate { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kf6yEeGNWvq8ppGEJQ_-1522341620")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Restriction { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kv6yEeGNWvq8ppGEJQ_855787094")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator OpeningDate { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0k_6yEeGNWvq8ppGEJQ_661525233")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AccountOwner { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0lP6yEeGNWvq8ppGEJQ_1458394401")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ReferenceAccount { get; init; } 
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0lf6yEeGNWvq8ppGEJQ_-1384463928")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public GenericIdentification42? Proprietary { get; init; } 
    
    
    #nullable disable
    
}
