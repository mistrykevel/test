extends Node2D

var LEFT = 0
var RIGHT = 1665

func _ready() -> void:
	var camera = get_node("CharacterTest/Camera2D")
	camera.limit_left = LEFT
	camera.limit_right = RIGHT
	
	camera.limit_smoothed = true
