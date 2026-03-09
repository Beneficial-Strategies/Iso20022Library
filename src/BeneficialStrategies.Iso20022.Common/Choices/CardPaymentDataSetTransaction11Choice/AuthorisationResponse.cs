// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction11Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_1ylO13JCEe299ZbWCkdR_w")]
    [DisplayName("Authorisation Response")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AuthorisationResponse : CardPaymentDataSetTransaction11Choice_
    #else
    public partial class AuthorisationResponse : CardPaymentDataSetTransaction11Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AuthorisationResponse instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AuthorisationResponse( System.String reqTransactionSequenceCounter,CardPaymentEnvironment79 reqEnvironment,CardPaymentTransaction129 reqTransaction,CardPaymentTransaction128 reqTransactionResponse )
        {
            TransactionSequenceCounter = reqTransactionSequenceCounter;
            Environment = reqEnvironment;
            Transaction = reqTransaction;
            TransactionResponse = reqTransactionResponse;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_rb4LoXJAEe299ZbWCkdR_w")]
        [DisplayName("Transaction Sequence Counter")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxSeqCntr")]
        #endif
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TransactionSequenceCounter { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransactionSequenceCounter { get; init; } 
        #else
        public System.String TransactionSequenceCounter { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_rb4Lo3JAEe299ZbWCkdR_w")]
        [DisplayName("Traceability")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tracblt")]
        #endif
        [IsoXmlTag("Tracblt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Traceability8? Traceability { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Traceability8? Traceability { get; init; } 
        #else
        public Traceability8? Traceability { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_rb4LpXJAEe299ZbWCkdR_w")]
        [DisplayName("Environment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Envt")]
        #endif
        [IsoXmlTag("Envt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentEnvironment79 Environment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentEnvironment79 Environment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentEnvironment79 Environment { get; init; } 
        #else
        public CardPaymentEnvironment79 Environment { get; set; } 
        #endif
        
        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_rb4Lp3JAEe299ZbWCkdR_w")]
        [DisplayName("Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tx")]
        #endif
        [IsoXmlTag("Tx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentTransaction129 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentTransaction129 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction129 Transaction { get; init; } 
        #else
        public CardPaymentTransaction129 Transaction { get; set; } 
        #endif
        
        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_rb4LqXJAEe299ZbWCkdR_w")]
        [DisplayName("Transaction Response")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxRspn")]
        #endif
        [IsoXmlTag("TxRspn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentTransaction128 TransactionResponse { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentTransaction128 TransactionResponse { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction128 TransactionResponse { get; init; } 
        #else
        public CardPaymentTransaction128 TransactionResponse { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
