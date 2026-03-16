using System.Reflection;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tests for <see cref="AccountReport25"/> demonstrating that
/// GitHub Issue #1 has been resolved: collections (Interest, Balance, Entry)
/// are now properly typed as ValueList&lt;T&gt; instead of single values.
/// </summary>
public class AccountReport25Tests
{
    /// <summary>
    /// Creates a minimal valid CashAccount39 for testing purposes.
    /// </summary>
    private static CashAccount39 CreateCashAccount() =>
        new CashAccount39 { Identification = new IBAN { Value = "DE89370400440532013000" } };

    /// <summary>
    /// Creates a minimal valid AccountReport25 for testing purposes.
    /// </summary>
    private static AccountReport25 CreateAccountReport() =>
        new AccountReport25 { Identification = "RPT-001", Account = CreateCashAccount() };

    [Fact]
    public void CanInstantiate_WithRequiredProperties()
    {
        // Arrange & Act
        var report = CreateAccountReport();

        // Assert
        Assert.NotNull(report);
        Assert.Equal("RPT-001", report.Identification);
        Assert.NotNull(report.Account);
    }

    /// <summary>
    /// Issue #1: Balance was incorrectly typed as a single CashBalance8?.
    /// This test proves it is now a ValueList collection.
    /// </summary>
    [Fact]
    public void Balance_PropertyType_IsValueList_NotSingleValue_Issue1Fixed()
    {
        // Arrange
        var balanceProperty = typeof(AccountReport25).GetProperty(nameof(AccountReport25.Balance));

        // Act
        var propertyType = balanceProperty!.PropertyType;

        // Assert - Should be ValueList<CashBalance8>, not CashBalance8?
        Assert.True(propertyType.IsGenericType, "Balance should be a generic type (ValueList<T>)");
        Assert.Equal("ValueList`1", propertyType.Name);
        Assert.Equal(typeof(CashBalance8), propertyType.GetGenericArguments()[0]);
    }

    /// <summary>
    /// Issue #1: Entry was incorrectly typed as a single ReportEntry10?.
    /// This test proves it is now a ValueList collection.
    /// </summary>
    [Fact]
    public void Entry_PropertyType_IsValueList_NotSingleValue_Issue1Fixed()
    {
        // Arrange
        var entryProperty = typeof(AccountReport25).GetProperty(nameof(AccountReport25.Entry));

        // Act
        var propertyType = entryProperty!.PropertyType;

        // Assert - Should be ValueList<ReportEntry10>, not ReportEntry10?
        Assert.True(propertyType.IsGenericType, "Entry should be a generic type (ValueList<T>)");
        Assert.Equal("ValueList`1", propertyType.Name);
        Assert.Equal(typeof(ReportEntry10), propertyType.GetGenericArguments()[0]);
    }

    /// <summary>
    /// Issue #1: Interest was incorrectly typed as a single AccountInterest4?.
    /// This test proves it is now a ValueList collection.
    /// </summary>
    [Fact]
    public void Interest_PropertyType_IsValueList_NotSingleValue_Issue1Fixed()
    {
        // Arrange
        var interestProperty = typeof(AccountReport25).GetProperty(
            nameof(AccountReport25.Interest)
        );

        // Act
        var propertyType = interestProperty!.PropertyType;

        // Assert - Should be ValueList<AccountInterest4>, not AccountInterest4?
        Assert.True(propertyType.IsGenericType, "Interest should be a generic type (ValueList<T>)");
        Assert.Equal("ValueList`1", propertyType.Name);
        Assert.Equal(typeof(AccountInterest4), propertyType.GetGenericArguments()[0]);
    }

    [Fact]
    public void Balance_IsInitializedAsEmptyCollection()
    {
        // Arrange & Act
        var report = CreateAccountReport();

        // Assert - Collection is initialized and ready to use
        Assert.NotNull(report.Balance);
        Assert.Empty(report.Balance);
    }

    [Fact]
    public void Entry_IsInitializedAsEmptyCollection()
    {
        // Arrange & Act
        var report = CreateAccountReport();

        // Assert - Collection is initialized and ready to use
        Assert.NotNull(report.Entry);
        Assert.Empty(report.Entry);
    }

    [Fact]
    public void Interest_IsInitializedAsEmptyCollection()
    {
        // Arrange & Act
        var report = CreateAccountReport();

        // Assert - Collection is initialized and ready to use
        Assert.NotNull(report.Interest);
        Assert.Empty(report.Interest);
    }

    /// <summary>
    /// Demonstrates that collections support Count property - a key difference from single values.
    /// </summary>
    [Fact]
    public void Collections_SupportCountProperty()
    {
        // Arrange
        var report = CreateAccountReport();

        // Assert - All collections have Count property (single values wouldn't)
        Assert.Equal(0, report.Balance.Count);
        Assert.Equal(0, report.Entry.Count);
        Assert.Equal(0, report.Interest.Count);
    }

    /// <summary>
    /// Demonstrates that collections support Add method - a key difference from single values.
    /// </summary>
    [Fact]
    public void Collections_SupportAddMethod()
    {
        // Arrange
        var report = CreateAccountReport();

        // Assert - All collections have Add method (would not compile if these were single values)
        var balanceAddMethod = report.Balance.GetType().GetMethod("Add");
        var entryAddMethod = report.Entry.GetType().GetMethod("Add");
        var interestAddMethod = report.Interest.GetType().GetMethod("Add");

        Assert.NotNull(balanceAddMethod);
        Assert.NotNull(entryAddMethod);
        Assert.NotNull(interestAddMethod);
    }

    /// <summary>
    /// Demonstrates that collections support indexer access - a key difference from single values.
    /// </summary>
    [Fact]
    public void Collections_SupportIndexerAccess()
    {
        // Arrange
        var report = CreateAccountReport();

        // Assert - All collections have indexer property
        var balanceIndexer = report.Balance.GetType().GetProperty("Item");
        var entryIndexer = report.Entry.GetType().GetProperty("Item");
        var interestIndexer = report.Interest.GetType().GetProperty("Item");

        Assert.NotNull(balanceIndexer);
        Assert.NotNull(entryIndexer);
        Assert.NotNull(interestIndexer);
    }

    /// <summary>
    /// Verifies collections implement IEnumerable for LINQ support.
    /// </summary>
    [Fact]
    public void Collections_AreEnumerable()
    {
        // Arrange
        var report = CreateAccountReport();

        // Assert
        Assert.IsAssignableFrom<System.Collections.IEnumerable>(report.Balance);
        Assert.IsAssignableFrom<System.Collections.IEnumerable>(report.Entry);
        Assert.IsAssignableFrom<System.Collections.IEnumerable>(report.Interest);
    }
}
