﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    int levelIndex;
    GameObject player, cam;
    public Animator animator;

    private Vector2 cpuLoc1 = new Vector2(-12.69f, 13.02f);
    private Vector2 cpuLoc2 = new Vector2(-12.69f, 13.02f);
    private Vector2 cpuLoc3 = new Vector2(-12.69f, 13.02f);
    private Vector2 cpuLoc4 = new Vector2(-12.69f, 13.02f);
    private Vector2 cpuLoc5 = new Vector2(-12.69f, 13.02f);
    private Vector2 cpuLoc6 = new Vector2(-12.69f, 13.02f);

    private void OnTriggerEnter2D(Collider2D col) {

        if (col.CompareTag("Player")) {

            PlayTransition(); // (In case we decide to add more sofisticated animation)

            // Choose the level to change based on collider's tag
            int.TryParse(gameObject.tag, out levelIndex);
            SceneManager.LoadScene(levelIndex);
        }
    }

    private void OnLevelWasLoaded() {

        levelIndex = SceneManager.GetActiveScene().buildIndex;

        // Retrieving camera and player objects in cpu scene
        player = GameObject.FindGameObjectWithTag("Player");
        cam = GameObject.FindGameObjectWithTag("MainCamera");

        if (levelIndex == 1) {

            // Setting location and rotation of player and camera
            player.transform.position = cpuLoc1;
            player.GetComponent<Rigidbody2D>().rotation = 0;
            cam.transform.position = cpuLoc1;

        } else if (levelIndex == 2) {

        } else if (levelIndex == 3) {

        } else if (levelIndex == 4) {

        } else if (levelIndex == 5) {

        } else if (levelIndex == 6) {

        }
    }

    

    public void PlayTransition() {
        animator.SetTrigger("TransitionIn");
    }
}