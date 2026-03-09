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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesOrCash1Choice
{
    /// <summary>
    /// Cash settlement chain parties and accounts.
    /// </summary>
    [IsoId("_yNcsADchEeOA3chqL9a4Rw")]
    [DisplayName("Cash Parties Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CashPartiesDetails : SecuritiesOrCash1Choice_
    #else
    public partial class CashPartiesDetails : SecuritiesOrCash1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CashPartiesDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CashPartiesDetails( PartyIdentificationAndAccount96 reqCreditor,PartyIdentificationAndAccount97 reqCreditorAgent )
        {
            Creditor = reqCreditor;
            CreditorAgent = reqCreditorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Party to which the payment amount must be ultimately delivered. In some cases, this may be a fund.
        /// </summary>
        [IsoId("_nszs4DcjEeOKPpUjhHfcCQ")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentificationAndAccount96 Creditor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentificationAndAccount96 Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount96 Creditor { get; init; } 
        #else
        public PartyIdentificationAndAccount96 Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution that services the cash account of the beneficiary (creditor). In some markets, this is also known as receiving agent. The creditor agent is the party where the payment amount must be ultimately delivered on behalf of the beneficiary (creditor), that is, the party where the beneficiary has its account.
        /// </summary>
        [IsoId("_ns0T_zcjEeOKPpUjhHfcCQ")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentificationAndAccount97 CreditorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentificationAndAccount97 CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount97 CreditorAgent { get; init; } 
        #else
        public PartyIdentificationAndAccount97 CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
        /// </summary>
        [IsoId("_ns0T8DcjEeOKPpUjhHfcCQ")]
        [DisplayName("Intermediary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Intrmy")]
        #endif
        [IsoXmlTag("Intrmy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentificationAndAccount97? Intermediary { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount97? Intermediary { get; init; } 
        #else
        public PartyIdentificationAndAccount97? Intermediary { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
        /// </summary>
        [IsoId("_6CPMETcjEeOKPpUjhHfcCQ")]
        [DisplayName("Intermediary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Intrmy2")]
        #endif
        [IsoXmlTag("Intrmy2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentificationAndAccount97? Intermediary2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount97? Intermediary2 { get; init; } 
        #else
        public PartyIdentificationAndAccount97? Intermediary2 { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
