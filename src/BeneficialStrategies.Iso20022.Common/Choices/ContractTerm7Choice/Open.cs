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
namespace BeneficialStrategies.Iso20022.Choices.ContractTerm7Choice
{
    /// <summary>
    /// Transaction is open term, that is, has no fixed maturity date.
    /// </summary>
    [IsoId("_xsKXYa5qEeuo-IflVgGqiA")]
    [DisplayName("Open")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Open : ContractTerm7Choice_
    #else
    public partial class Open : ContractTerm7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction.
        /// </summary>
        [IsoId("_x8jj0a5qEeuo-IflVgGqiA")]
        [DisplayName("Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MtrtyDt")]
        #endif
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? MaturityDate { get; init; } 
        #else
        public System.DateOnly? MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
        /// </summary>
        [IsoId("_x8jj065qEeuo-IflVgGqiA")]
        [DisplayName("Termination Option")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TermntnOptn")]
        #endif
        [IsoXmlTag("TermntnOptn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RepoTerminationOption2Code? TerminationOption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RepoTerminationOption2Code? TerminationOption { get; init; } 
        #else
        public RepoTerminationOption2Code? TerminationOption { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
