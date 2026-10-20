// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Microsoft.Data.Sqlite;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>
/// A throwaway SQLite database file for one test, so that every <c>DbContext</c> (the saga
/// repository's, and the test's own polling) opens its own connection.
/// </summary>
/// <remarks>
/// The first version of the Sqlite correlation tests shared ONE open <c>:memory:</c> connection
/// between the saga repository, which runs a database transaction for each message it correlates,
/// and the test's polling reads. A <see cref="SqliteConnection"/> is not safe to use from two
/// places at once, so the suite failed now and then (and, on a busy CI runner, often) with
/// "The transaction object is not associated with the same connection object", "database is locked"
/// or "unable to delete/modify user-function due to active statements" (#17).
/// A file in write-ahead-log mode lets each connection read while another writes, and each test
/// gets its own file, so the tests do not meet each other either. The file lives under the test
/// output folder (not the system temp folder) and is deleted when the test ends.
/// </remarks>
internal sealed class SqliteTestDatabase : IAsyncDisposable
{
    private readonly string _path;

    private SqliteTestDatabase(string path)
    {
        _path = path;
        ConnectionString = new SqliteConnectionStringBuilder
        {
            DataSource = path,
            Pooling = false, // a closed connection is really closed, so the file can be deleted
            DefaultTimeout = 30, // seconds a command waits for a lock held by another connection
        }.ToString();
    }

    /// <summary>The connection string each <c>DbContext</c> uses to open its own connection.</summary>
    public string ConnectionString { get; }

    /// <summary>Creates the file and puts it in write-ahead-log mode.</summary>
    public static async Task<SqliteTestDatabase> CreateAsync()
    {
        var folder = Path.Combine(AppContext.BaseDirectory, "sqlite-test-databases");
        Directory.CreateDirectory(folder);
        var database = new SqliteTestDatabase(Path.Combine(folder, $"{Guid.NewGuid():N}.db"));

        await using var connection = new SqliteConnection(database.ConnectionString);
        await connection.OpenAsync();
        await using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA journal_mode=WAL;"; // stays in the file, so every later connection has it
        await command.ExecuteNonQueryAsync();
        return database;
    }

    /// <summary>Deletes the database file and its write-ahead-log files.</summary>
    public ValueTask DisposeAsync()
    {
        SqliteConnection.ClearAllPools();
        foreach (var file in new[] { _path, _path + "-wal", _path + "-shm" })
            if (File.Exists(file))
                File.Delete(file);
        return ValueTask.CompletedTask;
    }
}
