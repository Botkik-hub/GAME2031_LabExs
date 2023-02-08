using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTest
{
    private readonly GameObject _playerPrefab = Resources.Load("Player") as GameObject;
    
    [Test]
    public void PlayerTestSimplePasses()
    {
        var player = Object.Instantiate(_playerPrefab);

        Assert.NotNull(player.GetComponent<Player>());
        Assert.NotNull(player.GetComponent<Rigidbody2D>());
        Assert.NotNull(player.GetComponent<CapsuleCollider2D>());
        Assert.NotNull(player.GetComponent<SpriteRenderer>());
        
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
