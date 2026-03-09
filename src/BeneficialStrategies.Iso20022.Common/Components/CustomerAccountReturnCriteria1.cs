// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates which fields must be present in the response.
/// </summary>
[IsoId("_vjD5tv6yEeGNWvq8ppGEJQ_1856817548")]
[DisplayName("Customer Account Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerAccountReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerAccountReturnCriteria1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerAccountReturnCriteria1( System.String reqIdentification,System.String reqName,System.String reqStatus,System.String reqType,System.String reqCurrency,System.String reqMonthlyPaymentValue,System.String reqMonthlyReceivedValue,System.String reqMonthlyTransactionNumber,System.String reqAverageBalance,System.String reqAccountPurpose,System.String reqFloorNotificationAmount,System.String reqCeilingNotificationAmount,System.String reqStatementCycle,System.String reqClosingDate,System.String reqRestriction,System.String reqOpeningDate,System.String reqAccountOwner,System.String reqReferenceAccount )
    {
        Identification = reqIdentification;
        Name = reqName;
        Status = reqStatus;
        Type = reqType;
        Currency = reqCurrency;
        MonthlyPaymentValue = reqMonthlyPaymentValue;
        MonthlyReceivedValue = reqMonthlyReceivedValue;
        MonthlyTransactionNumber = reqMonthlyTransactionNumber;
        AverageBalance = reqAverageBalance;
        AccountPurpose = reqAccountPurpose;
        FloorNotificationAmount = reqFloorNotificationAmount;
        CeilingNotificationAmount = reqCeilingNotificationAmount;
        StatementCycle = reqStatementCycle;
        ClosingDate = reqClosingDate;
        Restriction = reqRestriction;
        OpeningDate = reqOpeningDate;
        AccountOwner = reqAccountOwner;
        ReferenceAccount = reqReferenceAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkP6yEeGNWvq8ppGEJQ_1742978482")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkf6yEeGNWvq8ppGEJQ_859745195")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDkv6yEeGNWvq8ppGEJQ_-137327158")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Status { get; init; } 
    #else
    public System.String Status { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDk_6yEeGNWvq8ppGEJQ_-1134399511")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlP6yEeGNWvq8ppGEJQ_-365489421")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Currency { get; init; } 
    #else
    public System.String Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlf6yEeGNWvq8ppGEJQ_-1362561774")]
    [DisplayName("Monthly Payment Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyPmtVal")]
    #endif
    [IsoXmlTag("MnthlyPmtVal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MonthlyPaymentValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MonthlyPaymentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MonthlyPaymentValue { get; init; } 
    #else
    public System.String MonthlyPaymentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDlv6yEeGNWvq8ppGEJQ_1935333169")]
    [DisplayName("Monthly Received Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyRcvdVal")]
    #endif
    [IsoXmlTag("MnthlyRcvdVal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MonthlyReceivedValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MonthlyReceivedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MonthlyReceivedValue { get; init; } 
    #else
    public System.String MonthlyReceivedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDl_6yEeGNWvq8ppGEJQ_938260816")]
    [DisplayName("Monthly Transaction Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyTxNb")]
    #endif
    [IsoXmlTag("MnthlyTxNb")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MonthlyTransactionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MonthlyTransactionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MonthlyTransactionNumber { get; init; } 
    #else
    public System.String MonthlyTransactionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmP6yEeGNWvq8ppGEJQ_-58811537")]
    [DisplayName("Average Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgBal")]
    #endif
    [IsoXmlTag("AvrgBal")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AverageBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AverageBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AverageBalance { get; init; } 
    #else
    public System.String AverageBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmf6yEeGNWvq8ppGEJQ_-1055883890")]
    [DisplayName("Account Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPurp")]
    #endif
    [IsoXmlTag("AcctPurp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AccountPurpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountPurpose { get; init; } 
    #else
    public System.String AccountPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDmv6yEeGNWvq8ppGEJQ_-2052956243")]
    [DisplayName("Floor Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlrNtfctnAmt")]
    #endif
    [IsoXmlTag("FlrNtfctnAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator FloorNotificationAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FloorNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FloorNotificationAmount { get; init; } 
    #else
    public System.String FloorNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDm_6yEeGNWvq8ppGEJQ_1244938700")]
    [DisplayName("Ceiling Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClngNtfctnAmt")]
    #endif
    [IsoXmlTag("ClngNtfctnAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CeilingNotificationAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CeilingNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CeilingNotificationAmount { get; init; } 
    #else
    public System.String CeilingNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjNDnP6yEeGNWvq8ppGEJQ_247866347")]
    [DisplayName("Statement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtCycl")]
    #endif
    [IsoXmlTag("StmtCycl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator StatementCycle { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementCycle { get; init; } 
    #else
    public System.String StatementCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kP6yEeGNWvq8ppGEJQ_-749206006")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ClosingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClosingDate { get; init; } 
    #else
    public System.String ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kf6yEeGNWvq8ppGEJQ_-1522341620")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Restriction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Restriction { get; init; } 
    #else
    public System.String Restriction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0kv6yEeGNWvq8ppGEJQ_855787094")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator OpeningDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OpeningDate { get; init; } 
    #else
    public System.String OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0k_6yEeGNWvq8ppGEJQ_661525233")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountOwner { get; init; } 
    #else
    public System.String AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0lP6yEeGNWvq8ppGEJQ_1458394401")]
    [DisplayName("Reference Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefAcct")]
    #endif
    [IsoXmlTag("RefAcct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ReferenceAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReferenceAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReferenceAccount { get; init; } 
    #else
    public System.String ReferenceAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this field must be present in the response.
    /// </summary>
    [IsoId("_vjW0lf6yEeGNWvq8ppGEJQ_-1384463928")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification42? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification42? Proprietary { get; init; } 
    #else
    public GenericIdentification42? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
