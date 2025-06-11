extends CharacterBody2D

var speed := 300.0
var jump_speed := -400.0

var GRAVITY = ProjectSettings.get_setting("physics/2d/default_gravity")

func _physics_process(delta: float) -> void:
	velocity.y += GRAVITY * delta
	
	if Input.is_action_just_pressed("jump") and is_on_floor():
		velocity.y = jump_speed - (1/GRAVITY + 75)
	
	var direction = Input.get_axis("left", "right")
	velocity.x = direction * speed
	
	move_and_slide()
